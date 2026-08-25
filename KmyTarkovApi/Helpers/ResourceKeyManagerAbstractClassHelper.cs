using System;
using System.Collections.Generic;
using EFT;
using KmyTarkovReflection;

namespace KmyTarkovApi.Helpers
{
    public class ResourceKeyManagerAbstractClassHelper
    {
        private static readonly Lazy<ResourceKeyManagerAbstractClassHelper> Lazy =
            new Lazy<ResourceKeyManagerAbstractClassHelper>(() => new ResourceKeyManagerAbstractClassHelper());

        public static ResourceKeyManagerAbstractClassHelper Instance => Lazy.Value;

        public readonly RefHelper.FieldRef<object, Dictionary<string, string>>
            RefVoiceDictionary;

        public Dictionary<string, string> VoiceDictionary => RefVoiceDictionary.GetValue(null);

        private ResourceKeyManagerAbstractClassHelper()
        {
            RefVoiceDictionary =
                RefHelper.FieldRef<object, Dictionary<string, string>>.Create(
                    typeof(InGameBundles), "_phrasesPaths");
        }
    }
}
