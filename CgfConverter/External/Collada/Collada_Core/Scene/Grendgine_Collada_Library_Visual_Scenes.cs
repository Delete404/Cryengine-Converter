using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Library_Visual_Scenes
    {
        [XmlAttribute("id")]
        public string ID;

        [XmlAttribute("name")]
        public string Name;

        [XmlElement(ElementName = "asset")]
        public Grendgine_Collada_Asset Asset;

        [XmlElement(ElementName = "extra")]
        public Grendgine_Collada_Extra[] Extra;

        [XmlElement(ElementName = "visual_scene")]
        public Grendgine_Collada_Visual_Scene[] Visual_Scene;

    }
}

