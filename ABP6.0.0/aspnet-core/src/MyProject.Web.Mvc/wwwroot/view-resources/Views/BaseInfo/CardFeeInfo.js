(function () {
    $(function () {
        var _cardFeeInfoservice = abp.services.app.cardFeeInfo;
        $('#RefreshButton').click(function () {
            refreshOrganizationList();
        });
        function refreshOrganizationList() {
            location.reload(true)
        }
    })
})