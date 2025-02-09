/** @param {NS} ns */
export async function main(ns) {
  let svr = ns.args[0];
  let maxRam = ns.args[1];
  let weakRatio = ns.args[2];
  let growRatio = ns.args[3];
  let hackRatio = ns.args[4];
  ns.print("-- Deploying v1-miner to " + svr + " with ram " + maxRam + ", W" + weakRatio + "G" + growRatio + "H" + hackRatio);
  let sum = 0;
  let mult = 0;

  while(sum < maxRam){
    mult++;
    sum = 2.9 + (mult * ((1.75 * weakRatio) + (1.75 * growRatio) + (1.7 * hackRatio)));
    //2.9 to include current script ram size
  }
  mult--; //overcounted by 1
  if(mult === 0 && sum > maxRam){
    ns.print("Base ratio exceeds max ram: " + Number(sum).toFixed(2) + "GB");
    ns.exit();
  }
  let weakThreads = weakRatio * mult;
  let growwThreads = growRatio * mult;
  let hackThreads = hackRatio * mult;
  
  ns.exec("/v1-miner/v1-weak.js", svr, {threads: weakThreads}, svr);
  ns.exec("/v1-miner/v1-grow.js", svr, {threads: growwThreads}, svr);
  ns.exec("/v1-miner/v1-hack.js", svr, {threads: hackThreads}, svr);
  
}