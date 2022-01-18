using AbstractFactory.Abstract;
using AbstractFactory.Abstract.Products;
using AbstractFactory.Factory.Products;

namespace AbstractFactory.Factory
{
    public class MediaSocialFactory : AbstractFactoryPattern
    {
        public override MediaSocial CreateMediaSocial()
        {
            return new MediaSocialTwitter();
        }
    }
}