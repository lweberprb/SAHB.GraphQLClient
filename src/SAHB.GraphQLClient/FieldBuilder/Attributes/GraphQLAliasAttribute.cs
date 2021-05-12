using System;

namespace SAHB.GraphQLClient.FieldBuilder.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class GraphQLAliasAttribute : Attribute
    {
        public string Alias { get; }
        
        public GraphQLAliasAttribute(string alias)
        {
            Alias = alias;
        }
    }
}
