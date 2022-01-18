using System;
using AbstractFactory.Abstract;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryPattern factory = new MediaSocialFactory();
            var mediaSocial = factory.CreateMediaSocial();

            mediaSocial.Post("Meu Post", "Viagem Acapulco publicado primeiramente no");
            mediaSocial.Like();

        }
    }
}
