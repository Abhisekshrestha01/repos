<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AngularjsProject._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="myModule">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.7/angular.min.js"></script>
   
    <script src="/scripts/test.js?v=78"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
        <br />
        <div>
            10+20={{10+20}}
        </div>
        <br />
        <br />
        <div ng-controller="test1">
            {{Message}}
        </div>
        <br />
        <br />

        <div ng-controller="Channels" style="border: 1px solid">
            Show Product:
            <input type="number" step="1" min="0" max="3" ng-model="rowlimit" />
            <div ng-repeat="x in Message | limitTo:rowlimit">
                <div>
                    <img ng-src="{{x.imgpath}}" width="100px" height="100px" />
                </div>
                <div>Enter Name:<asp:TextBox ID="txt" runat="server" ng-model="x.name"></asp:TextBox></div>
                <div>Name:{{x.name | uppercase}}</div>

                <div>Type:{{x.type}}</div>
                <div>Status:{{x.status}}</div>
                <div>Launch Date:{{x.LaunchDate |  date:"MM/dd/yyyy"}}</div>
                <div>Product Price:{{x.ProductPrice |currency:"$"}}</div>
                <div>
                    <input type="button" value="ChangeStatus" ng-click="ChangeStatus(x)" />
                </div>
            </div>
            <div ng-controller="Channels" style="border: 1px solid">

                <div ng-repeat="x in Message | orderBy:name:true | limitTo:1">
                    <div>
                        <img ng-src="{{x.imgpath}}" width="100px" height="100px" />
                    </div>
                    <div>Enter Name:<asp:TextBox ID="TextBox1" runat="server" ng-model="x.name"></asp:TextBox></div>
                    <div>Name:{{x.name | uppercase}}</div>

                    <div>Type:{{x.type}}</div>
                    <div>Status:{{x.status}}</div>
                    <div>Launch Date:{{x.LaunchDate |  date:"MM/dd/yyyy"}}</div>
                    <div>Product Price:{{x.ProductPrice |currency:"$"}}</div>
                    <div>
                        <input type="button" value="ChangeStatus" ng-click="ChangeStatus(x)" />
                    </div>
                </div>

            </div>

            <div ng-controller="Channels" style="border: 1px solid">
                sort By
                <select ng-model="sortcolumn">
                    <option value="name">name</option>
                    <option value="type">type</option>
                    <option value="-ProductPrice">ProductPrice</option>
                </select>
                <div ng-repeat="x in Message | orderBy:sortcolumn">
                    <div>
                        <img ng-src="{{x.imgpath}}" width="100px" height="100px" />
                    </div>
                    <div>Enter Name:<asp:TextBox ID="TextBox2" runat="server" ng-model="x.name"></asp:TextBox></div>
                    <div>Name:{{x.name | uppercase}}</div>

                    <div>Type:{{x.type}}</div>
                    <div>Status:{{x.status}}</div>
                    <div>Launch Date:{{x.LaunchDate |  date:"MM/dd/yyyy"}}</div>
                    <div>Product Price:{{x.ProductPrice |currency:"$"}}</div>
                    <div>
                        <input type="button" value="ChangeStatus" ng-click="ChangeStatus(x)" />
                    </div>
                </div>

            </div>
            <div ng-controller="APIChannels" style="border: 1px solid">
                sort By
                <select ng-model="sortcolumn">
                    <option value="name">name</option>
                    <option value="type">type</option>

                </select>
                <div ng-repeat="x in Message | orderBy:sortcolumn">

                    <div>Enter Name:<asp:TextBox ID="TextBox3" runat="server" ng-model="x.name"></asp:TextBox></div>
                    <div>Name:{{x.name | uppercase}}</div>

                    <div>Type:{{x.type}}</div>
                    <div>Status:{{x.status}}</div>

                    <div>
                        <input type="button" value="ChangeStatus" ng-click="ChangeStatus(x)" />
                    </div>
                </div>
            </div>
    </form>
</body>
</html>
