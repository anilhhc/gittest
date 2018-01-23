var ngapp = angular.module('StudentApp',[])

ngapp.controller('StudentController', function ($scope,StudentService) {
    $scope.msg = "something here";
    getStudents();
    function getStudents(){
        StudentService.getStudents()
        .success(function(studs){
            $scope.students=studs;
            console.log($scope.students);
        })
        .error(function(error){
            $scope.status='Unable to add customer data'+error.message;
            console.log($scope.status);
        });
    }

});

ngapp.factory('StudentService',['http', function($http){
    var StudentService={};
    StudentService.getStudents=function(){
        return $http.get('test5/GetPersons');
    };
    return StudentService;
}])