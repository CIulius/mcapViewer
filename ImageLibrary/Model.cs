using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary
{
    public class Model : IModel
    {
        private string currentImagePath;
        private List<string> imagesList;

        public Model()
        {
            imagesList = new List<string> { "one", "two", "three" };
            currentImagePath = imagesList.First();
        }

        public string Path { get { return currentImagePath; } }
        public void showNextImage()
        {
            int index = -1;
            bool finded = false;

            while (index < imagesList.Count && finded != true)
            {
                index++;

                if (imagesList[index].Equals(currentImagePath))
                {
                    index++;
                    index %= imagesList.Count;

                    currentImagePath = imagesList[index];
                    finded = true;
                }
            }
        }

        public void showPreviousImage()
        {
            int index = imagesList.Count;
            bool finded = false;

            while (index > 0 && finded != true)
            {
                index--;

                if (imagesList[index].Equals(currentImagePath))
                {
                    index--;
                    if (index < 0)
                    {
                        index = imagesList.Count - 1;
                    }
                    currentImagePath = imagesList[index];
                    finded = true;
                }
            }
        }
    }
}