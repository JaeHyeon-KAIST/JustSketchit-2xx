using System;
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