<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserFormController extends Controller
{
    public function ShowUser(Request $req) {
        $req->validate(
            [
                "firstName" => "required|min:3|max:20",
                "lastName" => "required|min:3|max:20",
                "city" => "required|max:50",
            ]
            );
        
        $hobbies = $req->input("hobbies");

        return view("show_user", [
            "firstName" => $req->input("firstName"),
            "lastName" => $req->input("lastName"),
            "city" => $req->input("city"),
            "hobbies" => (($hobbies == "") ? [] : explode(", ", $hobbies ) )
        ]);
    }
}
