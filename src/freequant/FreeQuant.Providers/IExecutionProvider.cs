﻿// Type: SmartQuant.Providers.IExecutionProvider
// Assembly: SmartQuant.Providers, Version=1.0.5036.28339, Culture=neutral, PublicKeyToken=null
// MVID: 3D0E1BE3-2A81-422F-8BE5-1E2F3B27770F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Providers.dll

using SmartQuant.FIX;

namespace SmartQuant.Providers
{
  public interface IExecutionProvider : IProvider
  {
    event ExecutionReportEventHandler ExecutionReport;

    event OrderCancelRejectEventHandler OrderCancelReject;

    void SendNewOrderSingle(NewOrderSingle order);

    void SendOrderCancelRequest(OrderCancelRequest request);

    void SendOrderCancelReplaceRequest(OrderCancelReplaceRequest request);

    void SendOrderStatusRequest(OrderStatusRequest request);

    BrokerInfo GetBrokerInfo();

    void RegisterOrder(NewOrderSingle order);
  }
}
