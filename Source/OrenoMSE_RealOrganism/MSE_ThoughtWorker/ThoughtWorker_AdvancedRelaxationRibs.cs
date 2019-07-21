﻿using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    public class ThoughtWorker_AdvancedRelaxationRibs : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            int num = MSE_VanillaExtender.CountAddedParts(p.health.hediffSet, MSE_HediffDefOf.AdvancedRelaxationRib);
            if (num > 0)
            {
                return ThoughtState.ActiveAtStage(num - 1);
            }

            return false;
        }
    }
}
