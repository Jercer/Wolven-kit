using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FiendLure : W3QuestUsableItem
	{
		[RED("range")] 		public CFloat Range { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("cloudEntity")] 		public CHandle<CEntityTemplate> CloudEntity { get; set;}

		public W3FiendLure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FiendLure(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}