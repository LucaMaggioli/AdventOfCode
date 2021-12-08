let filepath = "./input_data.txt";

timesOfIncrement();

async function timesOfIncrement() {
  const fs = require("fs");
  let counter = 0;

  let filecontent = fs.readFileSync("./input_data.txt").toString();
  let linesArray = filecontent.split("\n");
  console.log(filecontent);
  console.log(linesArray);

  linesArray.forEach((line) => {
    if (line > linesArray[linesArray.indexOf(line) - 1]) {
      counter++;
    }
  });
  console.log(counter);
}

async function processLineByLine() {
  //library to read files
  const fs = require("fs");
  const readLine = require("readline");
  //function processLineByLine() {
  let prevNumber = -1;
  let currentSequence = 0;
  let longerSequence = 0;
  let totalIncreasedTImes = -1;

  const fileStream = fs.createReadStream(filepath);

  const rl = readLine.createInterface({
    input: fileStream,
    crlfDelay: Infinity,
    // Note: we use the crlfDelay option to recognize all instances of CR LF
    // ('\r\n') in input.txt as a single line break.
  });

  //for (const line of rl) {
  for await (const line of rl) {
    let actualNumber = parseInt(line);

    console.log(`actualNumber is ${actualNumber}`);
    console.log(`prevNumber is ${prevNumber}`);

    if (actualNumber > prevNumber) {
      console.log(`actual is bigger than prev`);
      currentSequence += 1;
      console.log(`so, currentSquence is ${currentSequence}`);
      totalIncreasedTImes += 1;
    } else {
      if (currentSequence > longerSequence) {
        longerSequence = currentSequence;
      }
      currentSequence = 0;
    }
    prevNumber = actualNumber;
  }
  console.log(`longer sequence is ${longerSequence}`);
  console.log(`total Increased times ${totalIncreasedTImes}`);
}

function readFIleStandart() {
  fs.readFile(filepath, "utf8", (err, data) => {
    if (err) {
      console.log(err);
      typeof returnsoleog(err);
    }
    console.log(data);
  });
}
