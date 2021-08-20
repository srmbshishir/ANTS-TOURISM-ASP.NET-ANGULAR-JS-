app.controller("SellerProfile", function ($scope, $http, ajax, $rootScope) {
    if ($rootScope.UserType != "Seller") {
        $location.path("/");
        return;
    }
    $scope.user = $rootScope;
    console.log($scope.user.UserName);
    $scope.edit = function (user) {
        console.log("ashshi");
        console.log(user);
        console.log(user.name);
        var d = {
            name: user.UserName,
            email: user.UserEmail,
            password: user.UserPassword,
            phone: user.UserPhone,
        };
        console.log(d);

        ajax.post("https://localhost:44384/api/User/edit/" + $rootScope.UserId, d,
            function (response) {
                console.log(response);
                alert("edited");
            },
            function (err) {
                console.log(err);
            }
        );
    }
});
