// using System;
// using System.Text;
// using X;
//
// namespace JSI.Cmd
// {
//     public class JSICmdToDoSomething : XLoggableCmd {
//     // fields
//
//     // private constructor
//     // private JSICmdToDoSomething(XApp app, ...) {
//     private JSICmdToDoSomething(XApp app) : base(app) {
//     }
//
//     // JSICmdToDoSomething.execute(jsi, ...);
//     public static bool execute(XApp app) {
//         JSICmdToDoSomething cmd = new JSICmdToDoSomething(app);
//         return cmd.execute();
//     }
//     
//     protected override bool defineCmd() {
//         throw new System.NotImplementedException();
//     }
//     
//     protected override String createLog() {
//         StringBuilder sb = new StringBuilder();
//         sb.Append(this.getClass().getSimpleName()).append("\t");
//
//         return sb.toString();
//     }
// }