using System.Configuration;

namespace Ingenico.Connect.Sdk
{
    class ShoppingCartExtensionConfiguration : ConfigurationElement
    {
        public ShoppingCartExtension ShoppingCartExtension
        {
            get
            {
                if (_shoppingCartExtension != null)
                {
                    return _shoppingCartExtension;
                }
                if (string.IsNullOrEmpty(Creator)
                    && string.IsNullOrEmpty(Name)
                    && string.IsNullOrEmpty(Version))
                {
                    return null;
                }
                return new ShoppingCartExtension(Creator, Name, Version);
            }
            set
            {
                _shoppingCartExtension = value;
                Creator = value.Creator;
                Name = value.Name;
                Version = value.Version;
            }
        }
        ShoppingCartExtension _shoppingCartExtension;

        [ConfigurationProperty("creator", IsRequired = true)]
        public string Creator
        {
            get
            {
                if (_creator == null)
                {
                    return (string)this["creator"];

                }
                return _creator;
            }
            set
            {
                if (IsReadOnly())
                {
                    _creator = value;
                    return;
                }
                this["creator"] = value;
            }

        }
        string _creator;

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                if (_name == null)
                {
                    return (string)this["name"];

                }
                return _name;
            }
            set
            {
                if (IsReadOnly())
                {
                    _name = value;
                    return;
                }
                this["name"] = value;
            }

        }
        string _name;

        [ConfigurationProperty("version", IsRequired = true)]
        public string Version
        {
            get
            {
                if (_version == null)
                {
                    return (string)this["version"];

                }
                return _version;
            }
            set
            {
                if (IsReadOnly())
                {
                    _version = value;
                    return;
                }
                this["version"] = value;
            }

        }
        string _version;
    }
}
