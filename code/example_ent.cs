using Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
	[HammerEntity]
	[EditorModel( "models/citizen_props/crate01.vmdl" )]
	public partial class example_ent : ModelEntity
	{
		[Property]
		PhysicsMotionType MotionType { get; set; }

		public override void Spawn()
		{
			base.Spawn();

			SetModel( "models/citizen_props/crate01.vmdl" );
			SetupPhysicsFromModel( MotionType );
		}

		[GameEvent.Tick.Server]
		public void Tick()
		{
			DebugOverlay.Text( $"Motion Type: {MotionType}", Position + (Vector3.Up * 10) );
		}
	}
}
