/** @param {NS} ns */
export async function main(ns) {
let svr = ns.args[0];
  while(true){
    await ns.weaken(svr);
    await ns.sleep(60000); //wait 1 min
  }
}