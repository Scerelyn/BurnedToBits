/** @param {NS} ns */
export async function main(ns) {
  ns.wget("https://github.com/Scerelyn/BurnedToBits/blob/main/v1-miner/v1-deployer.js", "v1-deployer.js");
  ns.wget("https://github.com/Scerelyn/BurnedToBits/blob/main/v1-miner/v1-grow.js", "v1-grow.js");
  ns.wget("https://github.com/Scerelyn/BurnedToBits/blob/main/v1-miner/v1-hack.js", "v1-hack.js");
  ns.wget("https://github.com/Scerelyn/BurnedToBits/blob/main/v1-miner/v1-weak.js", "v1-weak.js");
}