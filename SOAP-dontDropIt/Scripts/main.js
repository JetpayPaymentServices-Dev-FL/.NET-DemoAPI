$("[data-toggle=tooltip]").tooltip();
function generateAmount() {
    var dollars = Math.floor(Math.random() * 390 + 10),
    totalAmount = dollars.toString();
    return totalAmount;
}
$('.btnGenerate').click(function (event) {
    $.ajax({
        url: 'http://api.randomuser.me/?nat=us',
        dataType: 'json',
        success: function (data) {
            populateRandomData(data.results[0]);
        }
    });
    event.preventDefault();
});
function populateRandomData(obj) {
    $('#amount').val(generateAmount());
    $('#NAME').val(obj.name.first + ' ' + obj.name.last);
    $('#ADDRESS').val(obj.location.street);
    $('#ADDRESSTWO').val("590");
    $('#CITY').val(obj.location.city);
    $('[name=STATE] option').filter(function () {
        if ($(this).text().toLowerCase() == obj.location.state) {
            $('#STATE').val(this.value);
        }
    });
    $('#ZIP').val(obj.location.postcode);
    $('[name=COUNTRY] option').filter(function () {
        if ($(this).value == obj.nat) {
            $('#COUNTRY').val(this.value);
        }
    });
    $('#EMAIL').val(obj.email);
    $('#PHONE').val(obj.phone);
    $('#paymentID').val(Math.floor(100000000 + Math.random() * 900000000).toString());
    $('#paymentIDSecondary').val(Math.floor(100000000 + Math.random() * 900000000).toString());
    $('#lineItemAmount').val($('#amount').val());
    $('#NOTES').val('Test Transaction');
};
$('.btnSubmit').click(function (event) {
    $('.loader').fadeIn(function () {
        $(this).delay(5000).fadeOut();
    });
});
//function validateAreaCodePhone(phoneNumber) {
//    var formattedPhone = phoneNumber.replace(/[^\d]/g, '');
//    var phoneMinusArea = formattedPhone.slice(3, formattedPhone.length);
//    return '850' + phoneMinusArea;
//}