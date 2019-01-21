using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace TrabalhoFPI
{
    class OilPaintEffect
    {


        public static Bitmap CreateEffect(Bitmap originalImage, int radius, int intensity)
        {
            Retangulo grade = new Retangulo(radius, radius);
            Bitmap oilImage = new Bitmap(originalImage.Width, originalImage.Height);
            Color novoPixel = originalImage.GetPixel(0,0);

            
            for (int pixelIndexWidth = 0; pixelIndexWidth < originalImage.Width; pixelIndexWidth += 1)
            {
                for (int pixelIndexHeight = 0; pixelIndexHeight < originalImage.Height; pixelIndexHeight += 1)
                {
                    TabelaValores tabela = new TabelaValores(intensity);
                    for (int width = -radius; width <= radius; width++)
                    {

                        for (int height = -radius; height <= radius; height++)
                        {
                            if (pixelIndexWidth + width > -1 && pixelIndexWidth + width < originalImage.Width && pixelIndexHeight + height > -1 && pixelIndexHeight + height < originalImage.Height)
                            {
                                Color pixel = originalImage.GetPixel(pixelIndexWidth + width, pixelIndexHeight + height);

                                int nCurIntensity = Convert.ToInt32(((((int)pixel.R + (int)pixel.G + (int)pixel.B) / 3.0) * intensity) / 255);

                                tabela.adicionaValor(pixel.R, pixel.G, pixel.B, nCurIntensity);
                                novoPixel = tabela.retornaMaior();

                            }
                        }
                    }

                    for (int width = -radius; width <= radius; width++)
                    {
                        for (int height = -radius; height <= radius; height++)
                        {
                            if (pixelIndexWidth + width > -1 && pixelIndexWidth + width < originalImage.Width && pixelIndexHeight + height > -1 && pixelIndexHeight + height < originalImage.Height)
                            {
                                oilImage.SetPixel(pixelIndexWidth + width, pixelIndexHeight+height, novoPixel);


                            }
                        }
                    }
                    
                }
            }
            




            return oilImage;
        }

    }
}
