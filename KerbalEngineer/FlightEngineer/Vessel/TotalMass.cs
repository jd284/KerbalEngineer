﻿// Project:	KerbalEngineer
// Author:	CYBUTEK
// License:	Attribution-NonCommercial-ShareAlike 3.0 Unported

#region Using Directives

using KerbalEngineer.Extensions;
using KerbalEngineer.Simulation;

#endregion

namespace KerbalEngineer.FlightEngineer.Vessel
{
    public class TotalMass : Readout
    {
        protected override void Initialise()
        {
            this.Name = "Total Mass";
            this.Description = "Shows the total mass for the vessel.";
            this.Category = ReadoutCategory.Vessel;
        }

        public override void Update()
        {
            SimulationManager.RequestSimulation();
        }

        public override void Draw()
        {
            this.DrawLine(SimulationManager.LastStage.TotalMass.ToMass());
        }
    }
}