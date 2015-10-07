<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatePickerTester.aspx.cs" Inherits="IndentApplicationManagement.DatePickerTester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Good to work</title>
    <link href="Kendo/styles/kendo.rtl.css" rel="stylesheet" />
    <link href="Kendo/styles/kendo.common.min.css" rel="stylesheet" />
    <link href="Kendo/styles/kendo.default.min.css" rel="stylesheet" />
    <link href="Kendo/styles/kendo.mobile.all.min.css" rel="stylesheet" />
    <script src="Kendo/js/jszip.min.js"></script>
    <script src="Kendo/js/jquery.min.js"></script>
    <script src="Kendo/js/angular.min.js"></script>
    <script src="Kendo/js/kendo.all.min.js"></script>

</head>
<body>
    <form data-toggle="validator" role="form" id="form1" runat="server">
        <div class="form-group">
            <label for="inputName" class="control-label">Name</label>
            <input type="text" class="form-control" id="inputName" placeholder="Cina Saffary" required>
        </div>
        <div class="form-group has-feedback">
            <label for="inputTwitter" class="control-label">Twitter</label>
            <div class="input-group">
                <span class="input-group-addon">@</span>
                <input type="text" pattern="^[_A-z0-9]{1,}$" maxlength="15" class="form-control" id="inputTwitter" placeholder="1000hz" required>
            </div>
            <span class="glyphicon form-control-feedback" aria-hidden="true"></span>
            <span class="help-block with-errors">Hey look, this one has feedback icons!</span>
        </div>
        <div class="form-group">
            <label for="inputEmail" class="control-label">Email</label>
            <input type="email" class="form-control" id="inputEmail" placeholder="Email" data-error="Bruh, that email address is invalid" required>
            <div class="help-block with-errors"></div>
        </div>
        <div class="form-group">
            <label for="inputPassword" class="control-label">Password</label>
            <div class="form-group col-sm-6">
                <input type="password" data-minlength="6" class="form-control" id="inputPassword" placeholder="Password" required>
                <span class="help-block">Minimum of 6 characters</span>
            </div>
            <div class="form-group col-sm-6">
                <input type="password" class="form-control" id="inputPasswordConfirm" data-match="#inputPassword" data-match-error="Whoops, these don't match" placeholder="Confirm" required>
                <div class="help-block with-errors"></div>
            </div>
        </div>
        </div>
  <div class="form-group">
      <div class="radio">
          <label>
              <input type="radio" name="underwear" required>
              Boxers
          </label>
      </div>
      <div class="radio">
          <label>
              <input type="radio" name="underwear" required>
              Briefs
          </label>
      </div>
  </div>
        <div class="form-group">
            <div class="checkbox">
                <label>
                    <input type="checkbox" id="terms" data-error="Before you wreck yourself" required>
                    Check yourself
                </label>
                <div class="help-block with-errors"></div>
            </div>
        </div>
        <div class="form-group">
            <button type="submit" class="btn btn-primary">Submit</button>
        </div>
    </form>
    <script src="Kendo/examples/content/shared/js/products.js"></script>
    <script>

        $(document).ready(function () {

            $('#form1').validator();
        });

    </script>
    
</body>
</html>
