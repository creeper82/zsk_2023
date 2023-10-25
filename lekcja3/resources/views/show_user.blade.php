<div>
    <h3>Dane użytkownika</h3>
    <p>Imie masz { {$firstName }}</p>
    <p>Nazwisko {{ $lastName }}</p>
    <p>Miasto {{ $city }}</p>
    <p>Lisrta twoich hobbbbbbbyyyyyy</p>
    <ul>
        @foreach($hobbies as $hobby)
            <li>{{$hobby}}</li>
        @endforeach
    </ul>
</div>
