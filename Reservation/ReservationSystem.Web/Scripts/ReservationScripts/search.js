
$(document).ready(function () {

    /*
        Below code is to maintain the value of the form, if there
        is validation error in server side, we need to maintain value
        of form element.
    */
    $("#adultList").hide();
    $("#childrenList").hide();
    var roomsAdultList = document.getElementById("adultList").value;
    var roomsChildrenList = document.getElementById("childrenList").value;
    if (!isEmpty(roomsAdultList)) {
        var adultList = roomsAdultList.slice(0, -1).split(",");
        var childrenList = roomsChildrenList.slice(0, -1).split(",");
        for (var li in adultList) {
            var roomCount = parseInt(li) + 1;
            if (li > 0) {
                var panel = $("#SearchPanel").clone().addClass("clonedClass");
                panel.find("#Adult").val(adultList[li]);
                panel.find("#Children").val(childrenList[li]);
                panel.find("#RoomId").text("Room " + roomCount);
                panel.appendTo("#reservation");
            }
            else if (li == 0) {

                $("#SearchPanel").find("#RoomId").text("Room " + roomCount);
                $("#SearchPanel").find("#Adult").val(adultList[li]);
                $("#SearchPanel").find("#Children").val(childrenList[li]);
            }
        }
        document.getElementById("adultList").value = "";
        document.getElementById("childrenList").value = "";
    }

    /*
        Below code is to dynamically generate the ReservationDetail panel element
        consisting of Room number, Adult, and Children, When the dropdown list of 
        number of room is changed.
    */
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
            panel.find("#RoomId").text("Room " + parseInt(index + numberOfClonedClass + 1))
            panel.appendTo("#reservation");
        }
    });

    /*
        Below code is for datepicker in Check-in and Check-out and its validation.
        It uses bootstrap datepicker.
    */
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

    /*
        Below code is for autocomplete location. It uses typeheadJs
    */
    var cities = new Bloodhound({
        datumTokenizer: function (datum) {
            return Bloodhound.tokenizers.whitespace(datum.value);
        },
        queryTokenizer: Bloodhound.tokenizers.whitespace,
        remote: {
            url: 'https://api.teleport.org/api/cities/?search=%QUERY',
            filter: function (cities) {
                var objectList = cities._embedded["city:search-results"];
                return $.map(objectList, function (city) {
                    return {
                        value: city.matching_full_name
                    };
                });
            }
        }
    });

    cities.initialize();

    $('.typeahead').typeahead(null, {
        displayKey: 'value',
        source: cities.ttAdapter()
    });



    // Helper Methods


    function isEmpty(value) {
        return typeof value == 'string' && !value.trim() || typeof value == 'undefined' || value === null;
    }



});