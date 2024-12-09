using System.Collections.Generic;
using JSI.AppObject;
using UnityEngine;

namespace JSI
{
    public class JSIStandingCard : JSIAppNoGeom3D
    {
        // constants
        public static readonly Color COLOR_CARD = new Color(1f, 1f, 1f, 0.8f);
        public static readonly Color COLOR_UI_DEFAULT = new Color(0f, 0f, 0f, 0.15f);
        public static readonly Color COLOR_UI_SELECTED = new Color(0f, 0f, 1f, 0.3f);
        public static readonly float SCALE_HANDLE_RADIUS = 0.1f;
        
        // fields
        private JSIAppRect3D mCard = null;

        public JSIAppRect3D getCard()
        {
            return this.mCard;
        }

        private JSIAppCircle3D mStand = null;
        public JSIAppCircle3D getStand()
        {
            return this.mStand;
        }
        private JSIAppCircle3D mScaleHandle = null;
        public JSIAppCircle3D getScaleHandle()
        {
            return this.mScaleHandle;
        }

        private List<JSIAppPolyline3D> mPtCurve3Ds = null;
        public List<JSIAppPolyline3D> getPtCurve3Ds()
        {
            return this.mPtCurve3Ds;
        }
        
        // constructor
        public JSIStandingCard(string name, float width, float height, Vector3 pos, Quaternion rot, List<JSIAppPolyline3D> ptCurve3Ds) : base(name)
        {
            this.mGameObject.transform.localPosition = pos;
            this.mGameObject.transform.localRotation = rot;
            
            this.mCard = new JSIAppRect3D("Card", width, height, JSIStandingCard.COLOR_CARD);
            Vector3 standingLocalPos = 0.5f * height * Vector3.down;
            Quaternion standLocalRot = Quaternion.LookRotation(Vector3.up);
            this.mStand = new JSIAppCircle3D("Stand", 0.5f * width, JSIStandingCard.COLOR_UI_DEFAULT);
            this.mStand.getGameObject().transform.localPosition = standingLocalPos;
            this.mStand.getGameObject().transform.localRotation = standLocalRot;
            
            Vector3 scaleHandleLocalPos = 0.5f * height * Vector3.up;
            this.mScaleHandle = new JSIAppCircle3D("ScaleHandle", JSIStandingCard.SCALE_HANDLE_RADIUS, JSIStandingCard.COLOR_UI_DEFAULT);
            this.mScaleHandle.getGameObject().transform.localPosition = scaleHandleLocalPos;
            
            this.addChild(this.mCard);
            this.addChild(this.mStand);
            this.addChild(this.mScaleHandle);

            if (ptCurve3Ds == null)
            {
                return;
            }

            this.mPtCurve3Ds = ptCurve3Ds;
            foreach (JSIAppPolyline3D ptCurve in ptCurve3Ds)
            {
                this.mCard.addChild(ptCurve);
            }
        }
    }
}