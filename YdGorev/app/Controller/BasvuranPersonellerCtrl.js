angular.module('MyApp')

  .controller('BasvuranPersonellerCtrl', function ($scope, YdGorevService) {
    $scope.Data = null;
    YdGorevService.GetList().then(function (d) {
      $scope.Data = d.data;
      //toastr.success
    }), function () {
      toastr.error("Hata var");
    }
  })
  .factory('YdGorevService', function ($http) {
    var fac = {};
    fac.GetList = function () {
      return $http.get('/BasvuranPersoneller/GetList');
    }
    return fac;
  });
