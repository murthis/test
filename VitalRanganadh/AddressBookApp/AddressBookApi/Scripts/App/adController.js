app.controller('adController', ['$scope', 'adService',
    function ($scope, adService) {
        // Base Url   
        var baseUrl = '/api/AddressBook/';
        $scope.btnText = "Save";
        $scope.addressBookId = 0;

        $scope.SaveUpdate = function () {
            var student = {
                FirstName: $scope.firstName,
                LastName: $scope.lasttName,
                Email: $scope.email,
                Address: $scope.adress,
                AddressBookID: $scope.addressBookId
            }
            if ($scope.btnText == "Save") {
                var apiRoute = baseUrl;
                var saveStudent = adService.post(apiRoute, student);
                saveStudent.then(function (response) {
                    if (response.data != "") {
                        alert("Data Save Successfully");
                        $scope.GetStudents();
                        $scope.Clear();
                    } else {
                        alert("Some error");
                    }
                }, function (error) {
                    console.log("Error: " + error);
                });
            } else {
                var apiRoute = baseUrl;
                var UpdateStudent = adService.put(apiRoute, student);
                UpdateStudent.then(function (response) {
                    if (response.data != "") {
                        alert("Data Update Successfully");
                        $scope.GetStudents();
                        $scope.Clear();
                    } else {
                        alert("Some error");
                    }
                }, function (error) {
                    console.log("Error: " + error);
                });
            }
        }
        $scope.Clear = function () {
            $scope.addressBookId = 0;
            $scope.firstName = "";
            $scope.lasttName = "";
            $scope.email = "";
            $scope.adress = "";
        }

        $scope.GetStudents = function () {
            var apiRoute = baseUrl;
            var student = adService.getAll(apiRoute);
            student.then(function (response) {
               // debugger
                $scope.students = response.data;
            }, function (error) {
                console.log("Error: " + error);
            });
        }
        $scope.GetStudents();

        $scope.GetStudentByID = function (dataModel) {
            debugger
            var apiRoute = baseUrl;
            var student = adService.getbyID(apiRoute, dataModel.AddressBookId);
            student.then(function (response) {
                $scope.addressBookId = response.data.AddressBookId;
                $scope.firstName = response.data.FirstName;
                $scope.lasttName = response.data.LastName;
                $scope.email = response.data.Email;
                $scope.adress = response.data.Address;
                $scope.btnText = "Update";
            }, function (error) {
                console.log("Error: " + error);
            });
        }

        $scope.DeleteStudent = function (dataModel) {
            
            var apiRoute = baseUrl + dataModel.AddressBookId;
            var deleteStudent = adService.delete(apiRoute);
            deleteStudent.then(function (response) {
                if (response.data != "") {
                    alert("Data Delete Successfully");
                    $scope.GetStudents();
                    $scope.Clear();
                } else {
                    alert("Some error");
                }
            }, function (error) {
                console.log("Error: " + error);
            });
        }
    }
]);