using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNetwork
{
    class HopfieldNet
    {
        private const int _EPOCH = 1000; // эпоха

        private bool trained = false;
        private int NeuronsCount;
        private double[,] weights;
        private List<double[]> inputImages = new List<double[]>();
        public bool[][] Images
        {
            get
            {
                if (inputImages.Count == 0)
                {
                    return new bool[0][];
                }

                bool[][] res = new bool[inputImages.Count][];
                for (int i = 0; i < inputImages.Count; i++)
                {
                    res[i] = ConvertToBool(inputImages[i]);
                }
                return res;
            }
            private set { }
        }


        public HopfieldNet(int netSize)
        {
            NeuronsCount = netSize * netSize;
            weights = new double[NeuronsCount, NeuronsCount];
        }

        public HopfieldNet(bool[] inputImage)
        {
            NeuronsCount = inputImage.Length;
            weights = new double[NeuronsCount, NeuronsCount];
            inputImages.Add(ConvertToNum(inputImage));
            Training();
        }

        public HopfieldNet(bool[,] inputImages)
        {
            NeuronsCount = inputImages.GetLength(1);
            weights = new double[NeuronsCount, NeuronsCount];
            bool[][] inImg = ConvertInput(inputImages);
            for (int i = 0; i < inImg.Length; i++)
            {
                double[] img = ConvertToNum(inImg[i]);
                this.inputImages.Add(img);
            }
            Training();
        }


        public void AddImage(bool[] inputImage)
        {
            inputImages.Add(ConvertToNum(inputImage));
            trained = false;
        }

        public void AddImages(bool[,] inputImages)
        {
            bool[][] inImg = ConvertInput(inputImages);
            for (int i = 0; i < inImg.Length; i++)
            {
                double[] img = ConvertToNum(inImg[i]);
                this.inputImages.Add(img);
            }
            trained = false;
        }

        public void ClearImages()
        {
            inputImages.Clear();
            trained = false;
        }


        private void Training()
        {
            for (int image = 0; image < inputImages.Count; image++)
            {
                weights = SumMatrix(weights, MulByTranspMatrix(inputImages[image]));
            }
            trained = true;
        }

        public bool[] RecognizeImage(bool[] inputImage)
        {
            if (inputImages.Count != 0)
            {
                if (!trained)
                {
                    Training();
                }
                double[] image = ConvertToNum(inputImage);
                for (int epoch = 0; epoch < _EPOCH; epoch++)
                {
                    image = MultMatrix(weights, image);
                    if (CompareImages(image))
                    {
                        return ConvertToBool(image);
                    }
                }
                return null;
            }
            else
            {
                throw new Exception("В сети нет образов!");
            }
        }

        private bool CompareImages(double[] resImg)
        {
            bool res = true;
            for (int image = 0; image < inputImages.Count; image++)
            {
                res = true;
                double[] inputImage = inputImages[image];
                for (int i = 0; i < resImg.Length; i++)
                {
                    if (inputImage[i] != resImg[i])
                    {
                        res = false;
                        break;
                    }
                }
                if (res)
                {
                    return res;
                }
            }
            return res;
        }


        private double ActivFunc(double d)
        {
            if (d > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private double[] MultMatrix(double[,] m1, double[] m2)
        {
            double[] res = new double[m2.Length];

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    res[i] += m1[i, j] * m2[j];
                }
                res[i] = ActivFunc(res[i]);
            }
            return res;
        }

        private double[,] SumMatrix(params double[][,] matrixes)
        {
            double[,] res = new double[matrixes[0].GetLength(0), matrixes[0].GetLength(1)];

            for (int p = 0; p < matrixes.Length; p++)
            {
                double[,] m1 = res;
                double[,] m2 = matrixes[p];
                for (int i = 0; i < m1.GetLength(0); i++)
                {
                    for (int j = 0; j < m2.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            res[i, j] = 0;
                        }
                        else
                        {
                            res[i, j] = m1[i, j] + m2[i, j];
                        }
                    }
                }
            }
            return res;
        }

        private double[,] MulByTranspMatrix(double[] vector)
        {
            double[,] res = new double[vector.Length, vector.Length];

            for (int j = 0; j < vector.Length; j++)
            {
                double element = vector[j];
                for (int i = 0; i < vector.Length; i++)
                {
                    res[i, j] = element * vector[i];
                }
            }
            return res;
        }


        private double[] ConvertToNum(bool[] arr)
        {
            double[] res = new double[arr.Length];
            for (int i = 0; i < res.Length; i++)
            {
                switch (arr[i])
                {
                    case (false): { res[i] = -1; break; }
                    case (true): { res[i] = 1; break; }
                }
            }
            return res;
        }

        private bool[] ConvertToBool(double[] arr)
        {
            bool[] res = new bool[arr.Length];
            for (int i = 0; i < res.Length; i++)
            {
                if (arr[i] == -1)
                {
                    res[i] = false;
                }
                else
                {
                    res[i] = true;
                }
            }
            return res;
        }

        private bool[][] ConvertInput(bool[,] inputImages)
        {
            bool[][] res = new bool[inputImages.GetLength(0)][];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new bool[inputImages.GetLength(1)];
                for (int j = 0; j < res[i].Length; j++)
                {
                    res[i][j] = inputImages[i, j];
                }
            }
            return res;
        }
    }
}
