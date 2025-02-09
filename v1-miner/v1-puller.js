/** @param {NS} ns */
export async function main(ns) {
  await ns.wget("https://raw.githubusercontent.com/Scerelyn/BurnedToBits/refs/heads/main/v1-miner/v1-deployer.js", "v1-miner/v1-deployer.js");
  await ns.wget("https://raw.githubusercontent.com/Scerelyn/BurnedToBits/refs/heads/main/v1-miner/v1-grow.js", "v1-miner/v1-grow.js");
  await ns.wget("https://raw.githubusercontent.com/Scerelyn/BurnedToBits/refs/heads/main/v1-miner/v1-hack.js", "v1-miner/v1-hack.js");
  await ns.wget("https://raw.githubusercontent.com/Scerelyn/BurnedToBits/refs/heads/main/v1-miner/v1-weak.js", "v1-miner/v1-weak.js");
}