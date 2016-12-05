# VBR.UnixTime
> Converts UnixEpoch Date information to DateTime

By [v-braun - www.dev-things.net](http://www.dev-things.net).

## Installation

### PowerShell

```PowerShell
Install-Package VBR.UnixTime
```

### project.json

```json
  "dependencies": {
    "VBR.UnixTime": "*"
  }
```

## Usage
See the *VBR.UnixTime.Tests* Project.

```cs
using VBR;

static Main(){

    // static syntax
    var ms = 10; 
    var s = 11;
    var m = 12;
    var h = 13;

    var val1 = UnixTime.FromElapsedMinutes(ms);
    var val2 = UnixTime.FromElapsedMinutes(s);
    var val3 = UnixTime.FromElapsedMinutes(m);
    var val4 = UnixTime.FromElapsedMinutes(h);

    // extension syntax
    val1 = ms.MillisecondsSinceUnixEpoch();
    val2 = s.SecondsSinceUnixEpoch();
    val3 = m.MinutesSinceUnixEpoch();
    val4 = m.HoursSinceUnixEpoch();
}

```


### Known Issues

If you discover any bugs, feel free to create an issue on GitHub fork and
send me a pull request.

[Issues List](https://github.com/v-braun/VBR-UnixTime/issues).

## Authors

![image](https://avatars3.githubusercontent.com/u/4738210?v=3&s=50)  
[v-braun](https://github.com/v-braun/)



## Contributing

1. Fork it
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create new Pull Request


## License

See [LICENSE](https://github.com/v-braun/VBR-UnixTime/blob/master/LICENSE).
