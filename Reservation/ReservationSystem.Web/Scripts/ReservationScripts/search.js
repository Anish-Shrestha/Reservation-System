$(document).ready(function () {
    $("#adultList").hide();
    $("#childrenList").hide();
    var roomsAdultList = document.getElementById("adultList").value;
    var roomsChildrenList = document.getElementById("childrenList").value;
    if (roomsAdultList != "") {
        var adultList = roomsAdultList.slice(0, -1).split(",");
        var childrenList = roomsChildrenList.slice(0, -1).split(",");
        for (var li in adultList) {
            if (li > 0) {
                var panel = $("#SearchPanel").clone().addClass("clonedClass");
                panel.find("#Adult").val(adultList[li]);
                panel.find("#Children").val(childrenList[li]);
                panel.find("#RoomId").text("Room " + parseInt(li+1));
                panel.appendTo("#reservation");
            }
        }
        document.getElementById("adultList").value = "";
        document.getElementById("childrenList").value = "";
    }

    $("#SelectRoomDropdown").change(function () {
        var roomToBook = $("#SelectRoomDropdown").val();
        var numberOfClonedClass = $(".clonedClass").length + 1;
        if (numberOfClonedClass > roomToBook) {
            $(".clonedClass").each(function (index) {
                if (index + 2 > roomToBook) {
                    $(this).remove();
                }
            });
            return false;
        };

        for (var index = 0; index < roomToBook - numberOfClonedClass; index++) {
            var panel = $("#SearchPanel").clone().addClass("clonedClass");
            panel.find("#Adult").val(1);
            panel.find("#Children").val(1);
            panel.find("#RoomId").text("Room "+parseInt(index+numberOfClonedClass+1))
            panel.appendTo("#reservation");
        }
    });


    var todayTimeStamp = +new Date;
    var TimeStamp = 1000 * 60 * 60 * 24 * 2;
    var diff = todayTimeStamp - TimeStamp;
    var yesterday = new Date(diff);
    $('#Checkin').datepicker('setStartDate', yesterday);
    $('#Checkin').datepicker().on('changeDate', function (ev) {
        $('#Checkin').datepicker('hide');
    });
    $('#Checkout').datepicker('setStartDate', yesterday);
    $('#Checkout').datepicker().on('changeDate', function (ev) {
        $('#Checkout').datepicker('hide');
    });



});