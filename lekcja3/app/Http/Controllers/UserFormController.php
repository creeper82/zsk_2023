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
            ],
            [
                "firstName.required" => "Pole :attribute jest wymagane",
                "firstName.min" => "Pole :attribute musi mieć co najmniej :min znakow",
                "firstName.max" => "Pole :attribute może mieć maksymalnie :max znakow",
                "lastName.required" => "Pole :attribute jest wymagane",
                "lastName.min" => "Pole :attribute musi mieć co najmniej :min znakow",
                "lastName.max" => "Pole :attribute może mieć maksymalnie :max znakow",
                "city.required" => "Pole :attribute jest wymagane",
                "city.max" => "Pole :attribute może mieć maksymalnie :max znaków"
                
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
