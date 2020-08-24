using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionToCustomHit : CBTTaskPlayAnimationEventDecorator
	{
		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("waitTimeout")] 		public CFloat WaitTimeout { get; set;}

		[RED("activationTimeout")] 		public CFloat ActivationTimeout { get; set;}

		[RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[RED("receivedEvent")] 		public CBool ReceivedEvent { get; set;}

		[RED("isInCorrectBehGraphNode")] 		public CBool IsInCorrectBehGraphNode { get; set;}

		[RED("activationScriptEvent")] 		public CName ActivationScriptEvent { get; set;}

		[RED("deactivateScriptEvent")] 		public CName DeactivateScriptEvent { get; set;}

		public CBTTaskReactionToCustomHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionToCustomHit(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}