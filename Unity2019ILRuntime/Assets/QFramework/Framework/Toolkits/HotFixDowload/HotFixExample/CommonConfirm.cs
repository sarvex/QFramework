// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MyGame
{
    using UniRx;
    using UniRx.Triggers;


    public class CommonConfirmData : QFramework.UIPanelData
    {
    }

    public partial class CommonConfirm : QFramework.UIPanel
    {

        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {

        }

        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as CommonConfirmData ?? new CommonConfirmData();


        }

        protected override void OnOpen(QFramework.IUIData uiData)
        {
        }

        protected override void OnShow()
        {

        }

        protected override void OnHide()
        {
        }

        protected override void OnClose()
        {
        }

        public void Show(string title, string str, UnityEngine.Events.UnityAction confirmAction, UnityEngine.Events.UnityAction cancleAction)
        {
            Show();
            Title.text = title;
            HotFixDesText.text = str;

            ConfirmBtn.OnPointerClickAsObservable().Subscribe(_ =>
            {
                confirmAction();

            }).AddTo(gameObject);

            CancleBtn.OnPointerClickAsObservable().Subscribe(_ =>
            {
                cancleAction();
                Hide();
            }).AddTo(gameObject);
        }

    }
}
