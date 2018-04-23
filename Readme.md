# How to bind a SchedulerStorage to a RangeControl


<p>This example demonstrates how to bind a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraSchedulerSchedulerStoragetopic"><u>SchedulerStorage</u></a> to a <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRangeControltopic"><u>RangeControl</u></a>, so that appointment data held within the scheduler storage is rendered in the RangeControl's viewport. The <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridGridControltopic"><u>GridControl</u></a> control is used to show detailed information on appointments (subject, start time, end time, and description) that belong to the time interval that is currently selected in the RangeControl. To accomplish this task, create an instance of the <strong>SchedulerStorageRangeControlClient</strong> class and assign this object to the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRangeControl_Clienttopic"><u>RangeControl.Client</u></a> property. <br />
To obtain appointments that belong to the time range currently selected in the RangeControl, handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRangeControl_RangeChangedtopic"><u>RangeControl.RangeChanged</u></a> event and call the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_GetAppointmentstopic"><u>SchedulerStorageBase.GetAppointments</u></a> method. Assign the retrieved collection of appointments to <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridGridControl_DataSourcetopic"><u>GridControl.DataSource</u></a> to show appointment data in the GridControl.</p>

<br/>


