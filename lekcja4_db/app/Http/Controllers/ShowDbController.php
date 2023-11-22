<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class ShowDbController extends Controller
{
    public function showUsersTable() {
        $users = DB::table("users")->get();
        return $users;
    }
}
