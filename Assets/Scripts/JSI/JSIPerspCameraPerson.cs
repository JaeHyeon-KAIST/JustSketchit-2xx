
using UnityEngine;

namespace JSI
{
    public class JSIPerspCameraPerson : JSICameraPerson 
    {
        // constants
        public static readonly Color BG_COLOR = new Color(0.9f, 0.9f, 0.9f);
        public static readonly float FOV = 50f;
        public static readonly float NEAR = 0.01f;
        public static readonly float FAR = 100f;
        public static readonly Vector3 HOME_EYE = new Vector3(0f, 1f, -5f);
        public static readonly Vector3 HOME_VIEW = new Vector3(0f, 0f, 1f);
        public static readonly Vector3 HOME_PIVOT = new Vector3(0f, 0f, 0f);
        
        // fields
        private Vector3 mPivot = Vector3.zero;
        public Vector3 getPivot()
        {
            return this.mPivot;
        }
        public void setPivot(Vector3 pt)
        {
            this.mPivot = pt;
        }
        
        // constructor
        public JSIPerspCameraPerson() : base("PerspCameraPerson")
        {
            
        }

        protected override void defineExternalCameraParameters()
        {
            this.mCamera.clearFlags = CameraClearFlags.Color;
            this.mCamera.backgroundColor = JSIPerspCameraPerson.BG_COLOR;
            this.mCamera.cullingMask = 1; // default layout only

            this.mCamera.fieldOfView = JSIPerspCameraPerson.FOV;
            this.mCamera.nearClipPlane = JSIPerspCameraPerson.NEAR;
            this.mCamera.farClipPlane = JSIPerspCameraPerson.FAR;
        }
        
        protected override void defineInternalCameraParameters()
        {
            this.setEye(JSIPerspCameraPerson.HOME_EYE);
            this.setView(JSIPerspCameraPerson.HOME_VIEW);
            this.setPivot(JSIPerspCameraPerson.HOME_PIVOT);
        }
    }
}