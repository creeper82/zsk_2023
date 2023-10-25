<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserFormController extends Controller
{
    public function ShowUser(Request $req) {
        return view("show_user", [
            "firstName" => $req->input("firstName"),
            "lastName" => $req->input("lastName"),
            "city" => "not provided",
            "hobbies" => []
        ]);
    }
}
