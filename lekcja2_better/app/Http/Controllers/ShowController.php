<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ShowController extends Controller
{
    public function show() { return "it is a show controller lol"; }
    public function showFirstName() {
        $data = [
            "firstName" => "Janusz",
            "lastName" => "Nowak",
            "city"  => "Poznań",
        ];
        return View("data", ["data" => $data]);
    }
}
