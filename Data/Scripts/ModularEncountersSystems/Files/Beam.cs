﻿using System;
using System.Collections.Generic;
using System.Text;
using VRage;
using VRage.ObjectBuilders;

namespace ModularEncountersSystems.Files {

	public struct BeamsContainer {

		public Beam[] Beams;

	}

	public struct Beam {

		public string Name;
		public string BlockId;

		public BeamBehavior Behavior;
		public BeamEffect Effect;
		public BeamDamage Damage;

	}

	public struct BeamBehavior {

		public double MaxRange;
		public double PadDistanceFromOrigin;
		public bool BarrageCapable;

		public short PrefireTicks;

		public short FireTicks;

		public short PostfireTicks;

		public BeamBehavior(bool init = false) {

			MaxRange = 800;
			PadDistanceFromOrigin = 0;
			BarrageCapable = false;

			PrefireTicks = 0;

			FireTicks = 31;

			PostfireTicks = 0;

		}

	}

	public struct BeamEffect {

		public bool LinearBeam;
		public float LinearBeamMinWidth;
		public float LinearBeamMaxWidth;

		public SerializableVector3[] LinearBeamColors;
		public bool FadeThroughLinearBeamColors;

		public bool ElectricBeam;
		public float ElectricBeamMinWidth;
		public float ElectricBeamMaxWidth;

		public SerializableVector3 ElectricBeamColor;

		public string ImpactParticleId;
		public float ImpactParticleScale;
		public SerializableVector3 ImpactParticleColor;
		public int ImpactParticlePerTicks;

		public string PrefireSound;
		public string FireSound;
		public string HitSound;
		public string PostfireSound;

		public BeamEffect(bool init = false) {

			LinearBeam = false;
			LinearBeamMinWidth = 1;
			LinearBeamMaxWidth = 2;

			LinearBeamColors = new SerializableVector3[] { };
			FadeThroughLinearBeamColors = false;

			ElectricBeam = false;
			ElectricBeamMinWidth = 1;
			ElectricBeamMaxWidth = 2;

			ElectricBeamColor = new SerializableVector3();

			ImpactParticleId = "";
			ImpactParticleScale = 1;
			ImpactParticleColor = new SerializableVector3();
			ImpactParticlePerTicks = 60;

			PrefireSound = "";
			FireSound = "";
			HitSound = "";
			PostfireSound = "";

		}
	
	}

	public struct BeamDamage {

		public bool RegularDamage;
		public float RegularDamageAmount;

		public bool PenetrativeDamage;

		public bool ExplosionDamage;
		public float ExplosionDamageAmount;
		public float ExplosionDamageRadius;

		public bool TeslaDamage;
		public int TeslaDamageBlockCount;
		public int TeslaDamageEffectDuration;

		public bool ShieldDamage;
		public float ShieldDamageAmount;

		public BeamDamage(bool init = false) {

			RegularDamage = false;
			RegularDamageAmount = 100;

			PenetrativeDamage = false;

			ExplosionDamage = false;
			ExplosionDamageAmount = 300;
			ExplosionDamageRadius = 5;

			TeslaDamage = false;
			TeslaDamageBlockCount = 5;
			TeslaDamageEffectDuration = 10;

			ShieldDamage = false;
			ShieldDamageAmount = 1000;

		}

	}

}
