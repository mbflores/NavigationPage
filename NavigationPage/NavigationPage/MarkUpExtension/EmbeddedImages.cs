using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationPage.MarkUpExtension
{
    [ContentProperty("ResourceId")]
    class EmbeddedImages:IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceId))
            {
                return null;
            }

            return ImageSource.FromResource(ResourceId);
        }
    }
}
