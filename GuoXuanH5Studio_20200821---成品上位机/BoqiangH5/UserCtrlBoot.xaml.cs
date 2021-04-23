using BoqiangH5.BQProtocol;
using BoqiangH5.DDProtocol;
using BoqiangH5Entity;
using BoqiangH5Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BoqiangH5
{
    /// <summary>
    /// UserCtrlBoot.xaml 的交互逻辑
    /// </summary>
    public partial class UserCtrlBoot : UserControl
    {
        //List<H5BmsInfo> ListDeviceInfo = new List<H5BmsInfo>();
        public UserCtrlBoot()
        {
            InitializeComponent();

        }
        public event EventHandler RequireReadUIDInfoEvent;
        public event EventHandler RequireReadDeviceInfoEvent;
        public event EventHandler RequireReadBootInfoEvent;
        private void btnReadDevice_Clicked(object sender, RoutedEventArgs e)
        {
            tbDeviceType.Text = string.Empty;
            tbFirmwareNo.Text = string.Empty;
            tbHardwareNo.Text = string.Empty;
            tbManufactureInfo.Text = string.Empty;
            tbDeviceSn.Text = string.Empty;
            tbNumber.Text = string.Empty;
            tbFirmwareNum.Text = string.Empty;
            tbHardwareNum.Text = string.Empty;
            tbStatus.Text = string.Empty;
            isMsgVisible = true;
            RequireReadDeviceInfoEvent?.Invoke(this, EventArgs.Empty);
        }

        bool isMsgVisible = false;
        private void btnReadUID_Click(object sender, RoutedEventArgs e)
        {
            isMsgVisible = true;
            RequireReadUIDInfoEvent?.Invoke(this, EventArgs.Empty);
        }
        public void SetUID(string uid)
        {
            tbUID.Text = uid;
            if(isMsgVisible)
            {
                MessageBox.Show("读取UID成功！", "读取UID提示", MessageBoxButton.OK, MessageBoxImage.Information);
                isMsgVisible = false;
            }
        }
        private void btnReadBoot_Click(object sender, RoutedEventArgs e)
        {
            RequireReadBootInfoEvent.Invoke(this, EventArgs.Empty);
        }
        public void SetBootInfo(List<string>list)
        {
            UpdateBqBootInfo(list);
        }
        private void UpdateBqBootInfo(List<string> list)
        {
            if (list.Count == 6)
            {
                System.Windows.Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                {
                    tbProjectName.Text = list[0].Trim();
                    tbHardwareVersion.Text = list[1].Trim();
                    tbBootVersion.Text = list[2].Trim();
                    tbAppNum.Text = list[3].Trim();
                    tbProgramPhase.Text = list[4].Trim();
                    tbAppExist.Text = list[5].Trim();
                }));
            }
        }
        public void SetDeviceInfo(List<string> list)
        {
            UpdateDeviceInfo(list);
        }
        private void UpdateDeviceInfo(List<string> list)
        {
            System.Windows.Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                //for(int i = 0;i < list.Count;i++)
                //{
                //    ListDeviceInfo[i].StrValue = list[i];
                //}
                tbDeviceType.Text = list[0];
                tbFirmwareNo.Text = list[1];
                tbHardwareNo.Text = list[2];
                tbManufactureInfo.Text = list[3];
                tbDeviceSn.Text = list[4];
                tbNumber.Text = list[5];
                tbFirmwareNum.Text = list[6];
                tbHardwareNum.Text = list[7];
                tbStatus.Text = list[8];
                if(isMsgVisible)
                {
                    System.Windows.Forms.MessageBox.Show("读取设备信息成功！", "读取设备信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    isMsgVisible = false;
                }

            }));
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //XmlHelper.LoadXmlConfig("ProtocolFiles\\didi_h5_bms_info.xml", "device_info/register_node_info", ListDeviceInfo);
            //dgDeviceInfo.ItemsSource = ListDeviceInfo;
            //btnReadBoot.IsEnabled = false;
            //btnReadDevice.IsEnabled = false;
            //btnReadUID.IsEnabled = false;
            //if (SelectCANWnd.m_H5Protocol == H5Protocol.BO_QIANG)
            //    gbSleepTest.IsEnabled = false;
            //else
            //    gbSleepTest.IsEnabled = true;
        }

        public void HandleBootTestWndUpdateEvent(object sender, EventArgs e)
        {
            //if(MainWindow.m_statusBarInfo.IsOnline)
            //{
            //    btnReadBoot.IsEnabled = true;
            //    btnReadDevice.IsEnabled = true;
            //    btnReadUID.IsEnabled = true;
            //}
            //else
            //{
            //    btnReadBoot.IsEnabled = false;
            //    btnReadDevice.IsEnabled = false;
            //    btnReadUID.IsEnabled = false;
            //}
        }
    }
}
