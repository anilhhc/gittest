var app = angular.module("myApp", []);
app.controller("myCtrl", function ($scope, $http) {
    debugger;
    $scope.InsertData = function () {
        var Action = document.getElementById("btnSave").getAttribute("value");
        if (Action == "Submit") {
            $scope.Employe = {};
            $scope.Employe.hsfullname = $scope.hsfullname;
            $scope.Employe.hslastname = $scope.hslastname;
            $scope.Employe.hsemailid = $scope.hsemailid;
            $http({
                method: "post",
                url: "/HStockist/InsertStockist",
                datatype: "json",
                data: JSON.stringify($scope.Employe)
            }).then(function (response) {
                alert(response.data);
                $scope.GetAllData();
                $scope.hsfullname = "";
                $scope.hslastname = "";
                $scope.hsemailid = "";
            })
        } else {
            $scope.Employe = {};
            $scope.Employe.hsfullname = $scope.hsfullname;
            $scope.Employe.hslastname = $scope.hslastname;
            $scope.Employe.hsemailid = $scope.hsemailid;
            $scope.Employe.HstockistdetailsID = document.getElementById("EmpID_").value;
            $http({
                method: "post",
                url: "/HStockist/UpdateStockist",
                datatype: "json",
                data: JSON.stringify($scope.Employe)
            }).then(function (response) {
                alert(response.data);
                $scope.GetAllData();
                $scope.hsfullname = "";
                $scope.hslastname = "";
                $scope.hsemailid = "";
                document.getElementById("btnSave").setAttribute("value", "Submit");
                document.getElementById("btnSave").style.backgroundColor = "cornflowerblue";
                document.getElementById("spn").innerHTML = "Add New Employee";
            })
        }
    }
    $scope.GetAllData = function () {
        $http({
            method: "get",
            url:"/HStockist/GetAllStockists"
        }).then(function (response) {
            $scope.employees = response.data;
        }, function () {
            alert("Error Occur");
        })
    };
    $scope.DeleteEmp = function (Emp) {
        $http({
            method: "post",
            url: "/HStockist/DeleteStockist",
            datatype: "json",
            data: JSON.stringify(Emp)
        }).then(function (response) {
            alert(response.data);
            $scope.GetAllData();
        })
    };
    $scope.UpdateEmp = function (Emp) {
        document.getElementById("EmpID_").value = Emp.Emp_Id;
        $scope.hsfullname = Emp.hsfullname;
        $scope.hslastname = Emp.hslastname;
        $scope.hsemailid = Emp.hsemailid;
        document.getElementById("btnSave").setAttribute("value", "Update");
        document.getElementById("btnSave").style.backgroundColor = "Yellow";
        document.getElementById("spn").innerHTML = "Update Employee Information";
    }
})