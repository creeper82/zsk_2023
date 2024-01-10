<style>
    body {
        background-color: black;
        color: white;
    }
</style>

<div>
    <h3>Dane użytkownika</h3>
    <p>Imie masz {{$firstName }}</p>
    <p>Nazwisko {{ $lastName }}</p>
    <p>Miasto {{ $city }}</p>
    <p>Lista twoich hobby:</p>
    <ul>
        @if (sizeof($hobbies) == 0)
           <p>Nie masz hobby :c</p> 
        @else
            @foreach($hobbies as $hobby)
            <li>{{$hobby}}</li>
            @endforeach
        @endif
        
    </ul>
</div>
