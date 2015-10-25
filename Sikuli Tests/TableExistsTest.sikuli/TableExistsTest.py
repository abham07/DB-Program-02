import os
iepath = '%s\Internet Explorer\iexplore.exe' % os.environ['ProgramFiles']
App.open(iepath)
wait(Pattern(Pattern("1426120499761.png").similar(0.86)),10)
type ('l', KeyModifier.CTRL)
type ('http://localhost:52778/Model/WebForm1.aspx' + Key.ENTER)
find("1426127531924.png")
type ('f', KeyModifier.ALT)
wait (1)
type ('x')
chromepath = '%s\Google\Chrome\Application\chrome.exe' % os.environ['ProgramFiles(x86)']
openApp("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
wait("1426120615781.png",10)
type ('l', KeyModifier.CTRL)
type ('http://localhost:52778/Model/WebForm1.aspx' + Key.ENTER)
find("1426127610525.png")
type ('f', KeyModifier.ALT)
wait (1)
type ('x')