using System.Collections.Generic;
using JSI.AppObject;
using UnityEngine;

namespace JSI
{
    public class JSIGrid : JSIAppNoGeom3D
    {
        // constants
        private static readonly float LENGTH = 4.0f; // in meter
        private static readonly float WIDTH = 0.01f; // in meter
        private static readonly Color COLOR = new Color(0.75f, 0.75f, 0.75f);
        private static readonly int NUM_X_GRID_LINES = 5;
        private static readonly int NUM_Z_GRID_LINES = 5;

        // constructor
        public JSIGrid() : base("Grid")
        {
            // x-directional lines
            for (int i = 0; i < NUM_X_GRID_LINES; i++)
            {
                List<Vector3> pts = new List<Vector3>();
                pts.Add(new Vector3(-JSIGrid.LENGTH / 2f, 0f, (float)i - 2f));
                pts.Add(new Vector3(+JSIGrid.LENGTH / 2f, 0f, (float)i - 2f));
                JSIAppPolyline3D line = new JSIAppPolyline3D("XGridLine", pts, JSIGrid.WIDTH, JSIGrid.COLOR);
                this.addChild(line);
            }
            
            // z-directional lines
            for (int i = 0; i < NUM_Z_GRID_LINES; i++)
            {
                List<Vector3> pts = new List<Vector3>();
                pts.Add(new Vector3((float)i - 2f, 0f, -JSIGrid.LENGTH / 2f));
                pts.Add(new Vector3((float)i - 2f, 0f, +JSIGrid.LENGTH / 2f));
                JSIAppPolyline3D line = new JSIAppPolyline3D("XGridLine", pts, JSIGrid.WIDTH, JSIGrid.COLOR);
                this.addChild(line);
            }
        }
    }
}