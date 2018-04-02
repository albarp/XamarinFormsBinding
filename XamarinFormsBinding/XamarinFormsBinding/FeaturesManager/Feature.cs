using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsBinding.FeaturesManager
{
    public static class Feature
    {
        public static bool IsEnabled<T>() where T: IFeature
        {
            return FeatureToggleRegistry.ContainsEnabled<T>();
        }
    }
}
