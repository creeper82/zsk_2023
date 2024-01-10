<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ArrayController extends Controller
{
    public function ShowArray() {
        $user = [
            "firstName" => "Janusz",
            "lastName" => "Nowak",
            "city" => "Poznań",
            "hobbies" => ["żużel", "siatkówka", "programowanko w c#"]
        ];

        return view("show_user", $user);
    }
}
