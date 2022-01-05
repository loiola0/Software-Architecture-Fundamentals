using System;
using AbstractFactory.Abstract.Products;

namespace AbstractFactory.Factory.Products
{
    public class MediaSocialFacebook : MediaSocial
    {

        public override void Post(string title,string body)
        {
            Console.WriteLine(title);
            Console.WriteLine(body + " Facebook");
        }

        public override void Like()
        {
            Console.WriteLine("Essa publicação foi curtida");
        }

        
    }
}