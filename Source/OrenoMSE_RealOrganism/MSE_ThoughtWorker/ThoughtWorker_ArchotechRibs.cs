﻿using RimWorld;
using Verse;

namespace OrenoMSE_RealOrganism
{
    public class ThoughtWorker_ArchotechRibs : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            int num = MSE_VanillaExtender.CountAddedParts(p.health.hediffSet, MSE_HediffDefOf.ArchotechRib);
            if (num > 0)
            {
                return ThoughtState.ActiveAtStage(num - 1);
            }

            return false;
        }
    }
}
