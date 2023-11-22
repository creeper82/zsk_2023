<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class ShowDbController extends Controller
{
    public function showPageList()
    {
        return view("db.pagelist");
    }
    public function addSampleUser()
    {
        $insert = DB::table("users")->insert([
            "name" => "Krystyna",
            "email" => "krystyna" . rand(1, 999) . "@idk.pl",
            "password" => Hash::make("krystyna123")
        ]);

        return "Dodano pomyślnie";

    }
    public function showUsersTable()
    {
        $users = DB::table("users")->get();
        return $users;
    }

}
