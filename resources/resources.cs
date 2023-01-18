namespace mkht.PSAdvancedJsonCmdlet
{
    static class WebCmdletStrings
    {
        public const string DuplicateKeysInJsonString = "Cannot convert the JSON string because a dictionary that was converted from the string contains the duplicated key '{0}'.";
        public const string JsonDeserializationFailed = "Conversion from JSON failed with error: {0}";
        public const string EmptyKeyInJsonString = "The provided JSON includes a property whose name is an empty string, this is only supported using the -AsHashTable switch.";
        public const string KeysWithDifferentCasingInJsonString = "Cannot convert the JSON string because it contains keys with different casing. Please use the -AsHashTable switch instead. The key that was attempted to be added to the existing key '{0}' was '{1}'.";
        public const string JsonMaxDepthReached = "Resulting JSON is truncated as serialization has exceeded the set depth of {0}.";
        public const string NonStringKeyInDictionary = "The type '{0}' is not supported for serialization or deserialization of a dictionary. Keys must be strings.";
    }
}