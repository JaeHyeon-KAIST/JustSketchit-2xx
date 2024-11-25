using System;
using UnityEngine;
using X;

namespace JSI
{
    public class JSIApp : XApp
    {
        public override XScenarioMgr getScenarioMgr()
        {
            throw new System.NotImplementedException();
        }

        public override XLogMgr getLogMgr()
        {
            throw new System.NotImplementedException();
        }


        // Start is called before the first frame update
        private void Start()
        {
            Debug.Log("Hello World!");
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}