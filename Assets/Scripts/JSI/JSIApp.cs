using JSI.AppObject;
using UnityEngine;
using X;

namespace JSI
{
    public class JSIApp : XApp
    {
        // fields
        private JSIPerspCameraPerson mPerspCameraPerson = null;
        public JSIPerspCameraPerson getPerspCameraPerson()
        {
            return this.mPerspCameraPerson;
        }
        
        private JSIGrid mGrid = null;
        private XLogMgr mLogMgr = null;

        private XScenarioMgr mScenarioMgr = null;
        public override XScenarioMgr getScenarioMgr()
        {
            return this.mScenarioMgr;
        }

        public override XLogMgr getLogMgr()
        {
            return this.mLogMgr;
        }
        
        private JSIPenMarkMgr mPenMarkMgr = null;
        public JSIPenMarkMgr getPenMarkMgr()
        {
            return this.mPenMarkMgr;
        }
        
        private JSIKeyEventSource mKeyEventSource = null;
        private JSIMouseEventSource mMouseEventSource = null;
        private JSIEventListener mEventListener = null;


        // Start is called before the first frame update
        private void Start()
        {
            this.mPerspCameraPerson = new JSIPerspCameraPerson();
            this.mGrid = new JSIGrid();
            
            // new JSIAppRect3D("TestReact3D", 1f, 2f, new Color(0.5f, 0f, 0f, 0.5f));
            // new JSIAppCircle3D("TestCircle3D", 1f, new Color(0f, 0.5f, 0f, 0.5f));
            new JSIStandingCard("TestStandingCard", 1f, 2f, new Vector3(0f, 1f, 0f), Quaternion.identity, null);
            
            this.mScenarioMgr = new JSIScenarioMgr(this);
            this.mPenMarkMgr = new JSIPenMarkMgr();
            this.mLogMgr = new XLogMgr();
            this.mLogMgr.setPrintOn(true);
            
            this.mKeyEventSource = new JSIKeyEventSource();
            this.mMouseEventSource = new JSIMouseEventSource();
            this.mEventListener = new JSIEventListener(this);
            
            this.mKeyEventSource.setEventListener(this.mEventListener);
            this.mMouseEventSource.setEventListener(this.mEventListener);
        }

        // Update is called once per frame
        private void Update()
        {
            this.mKeyEventSource.update();
            this.mMouseEventSource.update();
        }
    }
}