<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dynamic control.aspx.cs" Inherits="LyfOn.Dynamic_control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>jQuery UI Sortable - Default functionality</title>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <link rel="stylesheet" href="/resources/demos/style.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        #sortable {
            list-style-type: none;
            margin: 0;
            padding: 0;
            width: 60%;
        }
 
            #sortable li {
                margin: 0 3px 3px 3px;
                padding: 0.4em;
                padding-left: 1.5em;
                font-size: 1.4em;
                height: 18px;
            }
 
                #sortable li span {
                    position: absolute;
                    margin-left: -1.3em;
                }
    </style>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <style>
        .lists {
            height: 200px;
            width: 300px;
            border: 1px solid #000000;
        }
    </style>
    <script>
        $(function () {
            $("#dynControl").sortable({
                connectWith: ".connectedSortable"
            }).disableSelection();
        });
    </script>
    <script>
        $(document).ready(function () {
 
            var CntrlType;
            var dspName;
            var mandatory;
            var $ctrl;
 
            $("#btnOk").click(function () {
                dspName = $('#txtDspName').val();
                mandatory = $('#chkMandatory')[0].checked;
 
                var $btndel = $('<span/>').attr({ style: 'padding-top: 30px', id: dspName, onclick: 'remove(this)' }).addClass("glyphicon glyphicon-remove");
 
                var $li = $('<li/>').attr({ id: 'li' + dspName });
                var $dvgrp = $('<div/>').addClass("form-group");
                var $lbl = $('<label/>').addClass("form-group").innerText = dspName;
 
                var $dvr = $('<div/>').addClass('col-sm-10');
                var $dvl = $('<div/>').addClass('col-sm-2');
 
                if (dspName != '') {
                    if (CntrlType == "txt") {
 
                        if ($('#chkMulti')[0].checked) {
                            $ctrl = $('<textarea/>').attr({ type: 'text', name: dspName, property: 'textarea' + ';' + dspName + ';' + mandatory }).addClass("form-control");
                       } else {
                            $ctrl = $('<input/>').attr({ type: 'text', name: dspName, property: 'text' + ';' + dspName + ';' + mandatory }).addClass("form-control");
                        }
 
                    }
                    if (CntrlType == "drp") {
 
                        $ctrl = $('<select/>');
                        for (i = 0; i < 10; i++) {
                            var $Option = $('<option />').innerText = 'Test1';
                            $sel.append($Option);
                        }
                    }
                    if (CntrlType == "rbt") {
                        $ctrl = $('<input/>').attr({ type: 'radio', name: 'rad' }).addClass("rad");
 
                    }
                    if (CntrlType == "chk") {
                        $ctrl = $('<input/>').attr({ type: 'checkbox', name: 'chk' }).addClass("chk");
                    }
 
                    $dvl.append($btndel);
 
                    $dvr.append($lbl);
                    $dvr.append($ctrl);
 
                    $dvgrp.append($dvr);
                    $dvgrp.append($dvl);
 
                    $li.append($dvgrp);
                    $("#dynControl").append($li);
 
                    $('#txtDspName').val('');
                    $('#chkMandatory')[0].checked = false;
 
                    $('#dvchkMulti').hide();
                    $('#dvddlvalues').hide();
                    $('#dvchkMulti')[0].checked = false;
 
                }
            });
 
            $(".click-btn").click(function () {
                CntrlType = "txt";
                $('#dvchkMulti').show();
            });
 
            $("#rad").click(function () {
                CntrlType = "rbt";
            });
 
            $("#drp").click(function () {
                CntrlType = "drp";
            });
 
            $("#chk").click(function () {
                cntrol = "drp";
                $('#dvddlvalues').show();
            });
 
            $("#btnCancel").click(function () {
                $('#dvddlvalues').hide();
                $('#dvchkMulti').hide();
                $('#dvchkMulti')[0].checked = false;
                $('#txtDspName').val('');
                $('#chkMandatory')[0].checked = false;
 
            });
        });
 
        function remove(cntrl) {         
            $('#li' + cntrl.id).remove();
        }
 
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="well text-center">
            <p>Dynamic control creation</p>
        </div>
        <div class="container">
 
            <div class="row">
                <div class="col-sm-3">
                    <div>
                        <div>
                            <input type="button" class="btn btn-default click-btn" id="txt" data-toggle="modal" data-target="#myModal" value="TextBox" />
                        </div>
                        <%--<div>
                            <input type="button" class="btn btn-default" id="chk" data-toggle="modal" data-target="#myModal" value="Add CheckBox" />
                        </div>
                        <div>
                            <input type="button" class="btn btn-default" id="rad" data-toggle="modal" data-target="#myModal" value="Radio button" />
                        </div>
                        <div>
                            <input type="button" class="btn btn-default" id="drp" data-toggle="modal" data-target="#myModal" value="Dropdown" />
                        </div>--%>
                    </div>
 
                </div>
                <div class="col-sm-9">
                    <ul id="dynControl" class="connectedSortable">
                    </ul>
                </div>
            </div>
        </div>
 
        <!-- Modal -->
        <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog" style="width: 350px;">
 
                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-body">
                        <div style="padding: 10px; border: 1px solid #ddd">
                            <div class="form-group">
                                <input class="form-control input-sm" placeholder="Display Name" id="txtDspName" type="text">
                            </div>
                            <div class="form-group" id="dvddlvalues" style="display: none">
                                <input class="form-control input-sm" placeholder="Display Name" id="txtddlValues" type="text">
                            </div>
                            <div class="form-group">
                                <div class="checkbox">
                                    <label>
                                        <input type="checkbox" id="chkMandatory" value="">Mandatory</label>
                                </div>
                            </div>
                            <div class="form-group" id="dvchkMulti" style="display: none">
                                <div class="checkbox">
                                    <label>
                                        <input type="checkbox" id="chkMulti" value="">Multiline TextBox</label>
                                </div>
                            </div>
                            <div>
                                <input type="button" class="btn btn-default" data-dismiss="modal" id="btnOk" value="Create" />
                                <input type="button" class="btn btn-default" data-dismiss="modal" id="btnCancel" value="Cancel" />
                            </div>
                        </div>
                    </div>
                </div>
 
            </div>
        </div>
    </form>
</body>
</html>
 

