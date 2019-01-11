using GameFramework.Procedure;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class ProcedureGame : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);

        //        CommonBinder.BindAll();
        //        ZooBinder.BindAll();
        //
        //        UIPackage.AddPackage("UI/Common");
        //        UIConfig.defaultFont = "tongxin";
        //        UIConfig.buttonSound = UIPackage.GetItemAsset("Common", "ButtonClick") as NAudioClip;
        //        UIConfig.buttonSoundVolumeScale = 1f;
        //
        //        var resManager = new FGuiResourceManager();
        //        resManager.Init();
        //        GameEntry.UI.SetResourceManager(resManager);
    }

    protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
    {
        base.OnLeave(procedureOwner, isShutdown);
    }

    protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
    }
}